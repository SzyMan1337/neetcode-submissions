public class TimeMap
{

    private Dictionary<string, List<(string value, int timestamp)>> store;
    public TimeMap()
    {
        store = new();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            store.Add(key, new List<(string value, int timestamp)>());
        }

        store[key].Add((value, timestamp));
    }

    public string Get(string key, int timestamp)
    {
        if(!store.ContainsKey(key)){
            return "";
        }

        var list = store[key];
        int l = 0, r = list.Count - 1;

        while (l < r)
        {
            int m = (l + r) / 2;

            if (list[m].timestamp == timestamp)
            {
                return list[m].value;
            }

            if (list[m].timestamp > timestamp)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        if(l >0 && list[l].timestamp > timestamp){
            l=l-1;
        }

        return list[l].timestamp >timestamp ? "": list[l].value;
    }
}
