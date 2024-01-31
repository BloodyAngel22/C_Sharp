using Northwind.Web;

Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder =>
{
	webBuilder.UseStartup<Startup>();
}).Build().Run();

System.Console.WriteLine("This is message executed after the web server stopped");