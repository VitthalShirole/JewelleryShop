namespace DBManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using BOL;

public class DBManager
{
    public static string constring = @"server=localhost; port=3306; user=root ;password=root123; database=JewelleryShop";


    public static List<Subcategory> subcategories()
    {
        List<Subcategory> catlist = new List<Subcategory>();

        MySqlConnection con = new MySqlConnection();

        con.ConnectionString = constring;

        try
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;

            string query = "SELECT * FROM SubCategory";
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int CatId = int.Parse(reader["SubCid"].ToString());
                string SubName = reader["SubName"].ToString();

                Subcategory subcat = new Subcategory(CatId, SubName);

                catlist.Add(subcat);
            }



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }


        return catlist;

    }

}