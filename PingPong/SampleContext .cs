using System.Data.Entity;

namespace PingPong
{
    public class SampleContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public SampleContext() : base("Data Source=DESKTOP-79P2B38\\SQLEXPRESS;Initial Catalog=PingPongScore;Integrated Security=True")
        { }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<HighScore> HighScores { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}