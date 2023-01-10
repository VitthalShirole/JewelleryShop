namespace BOL;
public class Subcategory
{
    public int SubCid { get; set; }
    public string SubName { get; set; }



    public Subcategory(int id, string name)
    {
        this.SubCid = id;
        this.SubName = name;

    }


}
