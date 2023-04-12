using mod8_1302210130;

internal class Program
{
    private static void Main(string[] args)
    {
        BankTransferConfig conf = new BankTransferConfig();
        int transferan; int ngasal; string confirm;
        if (conf.konfig.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
            transferan = Convert.ToInt32(Console.ReadLine());
            if (transferan > conf.konfig.transfer.threshold)
            {
                Console.WriteLine("Transfer fee = " + conf.konfig.transfer.high_fee);
                Console.WriteLine("Total amount = " + (transferan + conf.konfig.transfer.high_fee));
            }
            else
            {
                Console.WriteLine("Transfer fee = " + conf.konfig.transfer.low_fee);
                Console.WriteLine("Total amount = " + (transferan + conf.konfig.transfer.low_fee));
            }
            Console.WriteLine("Select transfer meethod:");
            for (int i = 0; i < conf.konfig.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + conf.konfig.methods[i]);
            }
            ngasal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type "+conf.konfig.conformation.en+" to confirm the trasaction:");
            confirm = Console.ReadLine();
            if (confirm == conf.konfig.conformation.en)
            {
                Console.WriteLine("Transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is canceled");
            }
        }
        else if (conf.konfig.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan anda transfer: ");
            transferan = Convert.ToInt32(Console.ReadLine());
            if (transferan > conf.konfig.transfer.threshold)
            {
                Console.WriteLine("Biaya transfer = " + conf.konfig.transfer.high_fee);
                Console.WriteLine("Total biaya = " + (transferan + conf.konfig.transfer.high_fee));
            }
            else
            {
                Console.WriteLine("Biaya transfer = " + conf.konfig.transfer.low_fee);
                Console.WriteLine("Total biaya = " + (transferan + conf.konfig.transfer.low_fee));
            }
            Console.WriteLine("Pilih metode transfer:");
            for (int i = 0; i < conf.konfig.methods.Count; i++)
            {
                Console.WriteLine((i + 1) +". "+ conf.konfig.methods[i]);
            }
            ngasal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type " + conf.konfig.conformation.id + " to confirm the trasaction:");
            confirm = Console.ReadLine();
            if (confirm == conf.konfig.conformation.id)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }
        }

    }
}