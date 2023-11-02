var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//need to see what i can add for mongo

// namespace SoloLearn
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers = new int[5];
//             int count = 0;
//             int sum = 0;
//             while (count <5)
//             {
//                 numbers[count] = Convert.ToInt32(Console.ReadLine());
//                 count++;
//             }
//             //your code goes here
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 if(numbers[i]%2 == 0)
//                 {
//                     sum += numbers[i];
//                 }
//             }
//             Console.WriteLine(sum);
//         }
//     }
// }