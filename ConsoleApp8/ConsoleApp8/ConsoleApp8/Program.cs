using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=PMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            int _choice = 0;
            int _ProdId = 0;
            String _ProducName = "";
            int _Quantity = 0;
            float _Price = 0.0f;
            int _SoldItem = 0;
            bool _prog = true;
            while (_prog)
            {

            Console.WriteLine("-----------PRODUCT MANAGMENT SYSTEM------------------");
            Console.WriteLine("1 -Input new product record.");
            Console.WriteLine("2 -Edit a Product.");
            Console.WriteLine("3  Delete a Product");
            Console.WriteLine("4 -Display all existing product.");
            Console.WriteLine("5 -Make a purchase.");
            Console.WriteLine("6 -Display all product with zero quantity.");
            Console.WriteLine("7 -Exit the program.");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Choice-->");
            _choice = int.Parse(Console.ReadLine());
            switch (_choice)
            {
                case 1:
                        Console.Write("Enter Product Name : ");
                        _ProducName = Console.ReadLine();
                        Console.Write("Enter Product Quantity : ");
                        _Quantity = int.Parse(Console.ReadLine());
                        Console.Write("Enter Product Price : ");
                        _Price = float.Parse(Console.ReadLine());
                         _conn.Open();
                        SqlCommand _sqCmd = new SqlCommand("INSERT INTO PRODUCTS(PRONAME,QUANTITY,PRICE)VALUES(@PRONAME,@QUANTITY,@PRICE)", _conn);
                        _sqCmd.Parameters.AddWithValue("@PRONAME",_ProducName);
                        _sqCmd.Parameters.AddWithValue("@QUANTITY",_Quantity);
                        _sqCmd.Parameters.AddWithValue("@PRICE",_Price);
                        _sqCmd.ExecuteNonQuery();
                        _conn.Close();
                        break;
                case 2:
                        Console.Write("Enter Product Id : ");
                        _ProdId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Product Name : ");
                        _ProducName = Console.ReadLine();
                        _conn.Open();
                        SqlCommand _sqUpdate = new SqlCommand("UPDATE PRODUCTS SET PRONAME = @PRONAME WHERE ID=@ID", _conn);
                        _sqUpdate.Parameters.AddWithValue("@ID", _ProdId);
                        _sqUpdate.Parameters.AddWithValue("@PRONAME", _ProducName);
                        _sqUpdate.ExecuteNonQuery();
                        _conn.Close();
                        Console.WriteLine("2");
                    break;
                case 3:
                        Console.Write("Enter Product Id : ");
                        _ProdId = int.Parse(Console.ReadLine());
                        _conn.Open();
                        SqlCommand _sqDelete = new SqlCommand("DELETE FROM PRODUCTS WHERE ID= @ID", _conn);
                        _sqDelete.Parameters.AddWithValue("@ID", _ProdId);
                       
                        _sqDelete.ExecuteNonQuery();
                        _conn.Close();
                        break;
                case 4:
                        _conn.Open();
                        SqlCommand _sqShow = new SqlCommand("SELECT * FROM PRODUCTS", _conn);
                        SqlDataReader _dReader = _sqShow.ExecuteReader();
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine("|Product Id|\t|Product Name|\t|Quantity|\t|Price|\t|Number of Sold Item");
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        while (_dReader.Read())
                        {
                            Console.WriteLine("|{0}|\t|{1}|\t|{2}|\t|{3}|\t|{4}",_dReader.GetInt32(0),_dReader.GetString(1),_dReader.GetInt32(2),_dReader.GetDouble(3),_dReader.GetInt32(4));
                        }
                        _conn.Close();

                       
                        break;
                case 5:
                        _conn.Open();
                        Console.Write("Enter Product Id : ");
                        _ProdId = int.Parse(Console.ReadLine());
                        Console.Write("Number of Item Purchased : ");
                        _Quantity = int.Parse(Console.ReadLine());
                        SqlCommand _SqlSale = new SqlCommand();
                        _SqlSale.CommandText = "UPDATE Products SET QUANTITY = QUANTITY - @QUANTITY,SOLDITEMS =  SOLDITEMS + @QUANTITY WHERE ID = @ID";
                        _SqlSale.Connection = _conn;
                        _SqlSale.Parameters.AddWithValue("@ID",_ProdId);
                        _SqlSale.Parameters.AddWithValue("@QUANTITY", _Quantity);
                        _SqlSale.ExecuteNonQuery();
                        
                     
                        _conn.Close();
                        break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                  
                        _prog = false;
                    break;
                default:
                    break;
            }

            Console.ReadKey();

            }

        }
    











            //String _sName = String.Empty;
            //String _sSem = "";
            //Console.Write("Enter Your Name : ");
            //_sName = Console.ReadLine();
            //Console.Write("Enter Your Semeter : ");
            //_sSem = Console.ReadLine(); 
            // SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY-218;Initial Catalog=sms;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //_sqlconn.Open();
            //SqlCommand _cmd = new SqlCommand("DELETE FROM STDINFO WHERE ID =@ID", _sqlconn);
            ////SqlCommand _cmd = new SqlCommand("INSERT INTO STDINFO VALUES(@STDNAME,@SEM)", _sqlconn);
            ////_cmd.Parameters.AddWithValue("@STDNAME", _sName);
            ////_cmd.Parameters.AddWithValue("@SEM", _sSem);
            //_cmd.Parameters.AddWithValue("@ID",1);
            //_cmd.ExecuteNonQuery();

            //_sqlconn.Close();


            
        }

     
    }

