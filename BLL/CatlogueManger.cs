namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;
public class CatlogueManager
{

    public List<Subcategory> allsubcatagories()
    {
        List<Subcategory> catlist = new List<Subcategory>();
        catlist = DAL.subcategories();

        return catlist;


    }




}
