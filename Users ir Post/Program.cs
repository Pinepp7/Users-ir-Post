using System;
using System.Reflection;
using Users_ir_Post.Contract;
using Users_ir_Post.Models;
using Users_ir_Post.Repository;
using Users_ir_Post.Servies;

class Program
{

    static void Main()
    {
        string connectiongString = "your_connection_string_here";

        IUserRepository userRepository = new UserRepository(connectiongString);
        IPostRepository postRepository = new PostRepository(connectiongString);

        UserService userService = new UserService(userRepository);
        PostService postService = new PostService(postRepository);  
        while(true)
        {
            Console.WriteLine("Meniu:");
            Console.WriteLine("1. Pridėti vartotoją");
            Console.WriteLine("2. Ištrinti vartotoją");
            Console.WriteLine("3. Gauti vartotoją");
            Console.WriteLine("4. Gauti visus vartotojus");
            Console.WriteLine("5. Pridėti įrašą");
            Console.WriteLine("6. Ištrinti įrašą");
            Console.WriteLine("7. Gauti įrašą");
            Console.WriteLine("8. Gauti visus įrašus");
            Console.WriteLine("9. Gauti vartotojo įrašus");
            Console.WriteLine("0. Išeiti");
            Console.Write("Pasirinkite: ");

            string pasirinkimas = Console.ReadLine();
            Console.Clear();

            switch (pasirinkimas)
            {
                case "1":
                    Console.Write("Vardas: ");
                    string name = Console.ReadLine();
                    Console.Write("El. paštas: ");
                    string email = Console.ReadLine();
                    userService.AddUser(new User { Name = name, Email = email });
                    break;
                case "2":
                    Console.Write("Vartotojo ID: ");
                    int deleteUserId = int.Parse(Console.ReadLine());
                    userService.DeleetUser(deleteUserId);
                    break;
                case "3":
                    Console.Write("Vartotojo ID: ");
                    int getUserId = int.Parse(Console.ReadLine());
                    User user = userService.GetUser(getUserId);
                    if (user != null)
                    {
                        Console.WriteLine($"ID: {user.Id}, Vardas: {user.Name}, El. paštas: {user.Email}");
                    }
                    else
                    {
                        Console.WriteLine("Vartotojas nerastas.");
                    }
                    break;
                case "4":
                    Console.Write("Vartotojo ID: ");
                    int userId = int.Parse(Console.ReadLine());
                    Console.Write("Pavadinimas: ");
                    string title = Console.ReadLine();
                    Console.Write("Turinys: ");
                    string content = Console.ReadLine();
                    postService.AddPost(new Post { UserId = userId, Title = title, Content = content });
                    break;
                case "5":
                    Console.Write("Įrašo ID: ");
                    int deletePostId = int.Parse(Console.ReadLine());
                    postService.DelletePost(deletePostId);
                    break;
                case "6":
                    Console.Write("Įrašo ID: ");
                    int getPostId = int.Parse(Console.ReadLine());
                    Post post = postService.GetPost(getPostId);
                    if (post != null)
                    {
                        Console.WriteLine($"ID: {post.Id}, Vartotojo ID: {post.UserId}, Pavadinimas: {post.Title}, Turinys: {post.Content}");
                    }
                    else
                    {
                        Console.WriteLine("Įrašas nerastas.");
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
                    break;




            }





        
        }
    }
}




