using Balta.ContentContext;

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientando-objetos"));
articles.Add(new Article("Segundo artigo sobre OOP", "orientando-objetos-2"));
articles.Add(new Article("Mais um artigo sobre POO", "orientando-objetos-3"));

// foreach (var article in articles)
// {
//   Console.WriteLine(article.Id);
//   Console.WriteLine(article.Title);
//   Console.WriteLine(article.Url);
// }

var courses = new List<Course>();

var courseOOP = new Course("Fundamentos OOP", "fundamentos-objetos");
var courseCSharp = new Course("C#", "csharp");
var courseAspNet = new Course("ASP .NET", "asp-net");

courses.Add(courseOOP);
courses.Add(courseCSharp);
courses.Add(courseAspNet);

var careeres = new List<Career>();

var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var itemCareer2 = new CareerItem(2, "Aprenda OOP", "", null);
var itemCareer = new CareerItem(1, "Comece por aqui", "", courseCSharp);
var itemCareer3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
careerDotnet.Items.Add(itemCareer2);
careerDotnet.Items.Add(itemCareer3);
careerDotnet.Items.Add(itemCareer);

careeres.Add(careerDotnet);

foreach (var career in careeres)
{
  Console.WriteLine(career.Title);
  foreach (var item in career.Items.OrderBy(x => x.Ordem))
  {
    Console.WriteLine($"{item.Ordem} - {item.Title} - {item.Course?.Title} / {item.Course?.Level}");
    foreach (var notify in item.Notifications)
    {
      Console.WriteLine($"{notify.Property} - {notify.Message}");
    }
  }
}