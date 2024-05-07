namespace CadastroProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Dados\Estoque\", file = "products.txt";

            Product CreateProduct()
            {
                Console.WriteLine("----- CRIAR PRODUTO -----");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("\nDescrição: ");
                string description = Console.ReadLine();
                Console.Write("\nPreço: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("\nQuantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                return new Product(id, description, price, quantity);
            }

            List<Product> ProductList = new();
            ProductList.Add(CreateProduct());

            void ShowAll(List<Product> list)
            {
                foreach (Product product in list) { Console.WriteLine(product.ToString()); }
            }

            ShowAll(ProductList);

            ProductList.Add(CreateProduct());

            ShowAll(ProductList);

            SaveFile(ProductList, path, file);

            void SaveFile(List<Product> list, string p, string f)
            {
                if (CheckIfExists(p, f))
                {
                    StreamWriter sw = new(p + f);

                    foreach (Product product in list)
                    {
                        sw.WriteLine(product.ToString());
                    }

                    sw.Close();

                    Console.WriteLine("Seu novo arquivo salvo:\n\n");
                    StreamReader sr = new(p + f);
                    sr.ReadToEnd();
                    sr.Close();
                }
            }

            bool CheckIfExists(string p, string f)
            {
                if (!Directory.Exists(p)) Directory.CreateDirectory(p);
                if (!File.Exists(p + f)) File.Create(p + f);

                return true;
            }

            List<Product> LoadFile(string p, string f)
            {
                List<Product> list = new();
                if (CheckIfExists(p, f))
                {
                    foreach (string line in File.ReadAllLines(p + f))
                    {
                        string[] props;

                        props = line.Split(";");
                        int id = int.Parse(props[0]);
                        string description = props[1];
                        double price = double.Parse(props[2]);
                        int quantity = int.Parse(props[3]);

                        list.Add(new Product(id, description, price, quantity));
                    }
                }
                return list;
            }
        }
    }
}