namespace DAL;
using BOL;
public class DAL
{


    public static List<Subcategory> subcategories()
    {
        List<Subcategory> catlist = new List<Subcategory>();

        catlist.Add(new Subcategory(101, "Rings"));

        catlist.Add(new Subcategory(102, "Earrings"));

        catlist.Add(new Subcategory(103, "Bracelet"));

        catlist.Add(new Subcategory(104, "MangalSutra"));

        catlist.Add(new Subcategory(105, "Pendents & Necklaces"));

        catlist.Add(new Subcategory(106, "Chains"));

        catlist.Add(new Subcategory(107, "Coins"));

        catlist.Add(new Subcategory(108, "Others"));

        return catlist;

    }


}
