string username = "admin";
string password = "123";
Console.WriteLine("Kullanıcı Adı:");
string userusername = Console.ReadLine();
Console.WriteLine("Şifre:");
string userpassword = Console.ReadLine();
bool enter = username == userusername && password == userpassword;
Console.WriteLine("Giriş Durumu:" + enter);