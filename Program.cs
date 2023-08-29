using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object
            Student student = new Student { Name = "Alice", Age = 20 };

            // Initialize the BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Define the file path
            string filePath = @"C:\TextFolder\serialize.txt";

            // Serialize the Student object
            using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fileStream, student);
            }

            Console.WriteLine("Serialization complete.");
            Console.WriteLine("============================");

            // Deserialize the Student object
            using (Stream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Student deserializedStudent = (Student)formatter.Deserialize(fileStream);
                Console.WriteLine($"Deserialized Student - Name: {deserializedStudent.Name}, Age: {deserializedStudent.Age}");
            }
        }
    
    }
}