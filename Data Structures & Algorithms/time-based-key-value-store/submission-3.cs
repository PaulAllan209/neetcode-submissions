public class TimeMap {
    public Dictionary<string, List<(string, int)>> dict;
    public TimeMap() {
        dict = new Dictionary<string, List<(string, int)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)) {
            dict.Add(key, new List<(string, int)>());
        }

        dict[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        var res = "";
        if(!dict.TryGetValue(key, out var values)) return "";

        var l = 0;
        var r = values.Count - 1;

        while (l <= r) {
            int m = (l + r)/2;
            if (values[m].Item2 <= timestamp) {
                res = values[m].Item1;
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }
        return res;
    }
}
