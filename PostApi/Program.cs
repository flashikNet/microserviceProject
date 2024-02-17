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

/// <summary>
/// Пост
/// </summary>
public class Post
{
    /// <summary>
    /// Идентификатор поста считается отдельно для каждого автора
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// Идентификатор автора поста, вместе с ид самого поста формируют первичный ключ 
    /// </summary>
    public uint AuthorId { get; set; }
    /// <summary>
    /// Время создания поста
    /// </summary>
    public DateTime Time { get; set; }
    /// <summary>
    /// Наполнение поста
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Количество репостов
    /// </summary>
    public uint RepostCount { get; set; }
    /// <summary>
    /// Количество лайков
    /// </summary>
    public uint LikeCount { get; set; }
    /// <summary>
    /// Количество просмотров
    /// </summary>
    public uint ViewCount {  get; set; }
    /// <summary>
    /// (id, authorId) ссылается на пост на который отвечает, если id == 0, значит самостоятельный пост, а не комментарий
    /// </summary>
    public (uint, uint) MotherPost {  get; set; }
    
}

class PostCounter
{
    public uint AuthorId { get; set; }
    public uint PostCount {  get; set; }
}
