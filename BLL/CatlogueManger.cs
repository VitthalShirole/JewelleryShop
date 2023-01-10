namespace BLL;
using BOL;
using DAL;
using DBManager;
using System.Collections.Generic;
public class CatlogueManager
{

    public List<Subcategory> allsubcatagories()
    {
        List<Subcategory> catlist = new List<Subcategory>();
        catlist = DAL.subcategories();

        return catlist;


    }

    public List<Subcategory> dballsubcategories()
    {

        List<Subcategory> catlist = new List<Subcategory>();

        catlist = DBManager.subcategories();

        return catlist;
    }



}
