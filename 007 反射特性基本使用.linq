<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Serialization</Namespace>
</Query>

void Main()
{
	var employee = new Employee(){
		Id = new Guid(),
		FirstName = "Johb",
		LastName = "Bob",
		Age = 24,
		DateOfBirth = DateTime.Now,
		Skills = new List<string>() {"CSharp","Java","Go","Python"}
	};
	
	var settings = new JsonSerializerSettings{
		Formatting = Newtonsoft.Json.Formatting.Indented,
		ContractResolver = new DefaultContractResolver{
			NamingStrategy = new SnakeCaseNamingStrategy()
		},
	};
	
	JsonConvert.SerializeObject(employee,settings).Dump();
}

class Employee{
	[JsonIgnore]
	public Guid Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	[JsonProperty("BirthDay")]
	public DateTime DateOfBirth { get; set; }
	public List<string> Skills { get; set; }
}