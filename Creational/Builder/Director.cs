using System.Text;
namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA(); builder.BuildPartB();
        }
    }
}