using System.Text.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

string json = File.ReadAllText("load.txt");

var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<TagsPhoto>>(json);//First element null
var resultSecond = JsonConvert.DeserializeObject<IEnumerable<TagsPhoto>>(json);
Console.WriteLine(result.First().Tag ?? "null");// Tag == null
Console.WriteLine(resultSecond.First().Tag);//Tag is not null

Console.ReadKey();


public class TagsPhoto
{
    public string Tag { set; get; }
    public float Probability { set; get; }
}

