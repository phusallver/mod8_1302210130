using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod8_1302210130
{
    internal class BankTransferConfig
    {
        public Konfig konfig;
        private const string filepath = @"configidk.json";

        public BankTransferConfig()
        {
            try
            {
                ReadKonfigFile();
            }
            catch
            {
                SetDefault();
                WriteKonfigFile();
            }
        }
        public void ReadKonfigFile()
        {
            string hasilBaca = File.ReadAllText(filepath);
            konfig = JsonSerializer.Deserialize<Konfig>(hasilBaca);
        }
        public void WriteKonfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string tulisan = JsonSerializer.Serialize(konfig, options);
            File.WriteAllText(filepath, tulisan);
        }
        public void SetDefault()
        {
            konfig = new Konfig();
            konfig.lang = "id";
            konfig.transfer = new Transfer();
            konfig.transfer.threshold = 25000000;
            konfig.transfer.low_fee = 6500;
            konfig.transfer.high_fee = 15000;
            konfig.methods = new List<string>();
            konfig.methods.Add("RTO(real-time)");
            konfig.methods.Add("SKN");
            konfig.methods.Add("RTGS");
            konfig.methods.Add("BI FAST");
            konfig.conformation = new Conformation(); 
            konfig.conformation.en = "yes";
            konfig.conformation.id = "ya";
        }
    }
}

public class Konfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public Conformation conformation { get; set; }
    public Konfig() { }
}
public class Transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set;}
    public Transfer() { }
}
public class Conformation
{
    public string en { get; set; }
    public string id { get; set; }
    public Conformation() { }
}