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
/// ����
/// </summary>
public class Post
{
    /// <summary>
    /// ������������� ����� ��������� �������� ��� ������� ������
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// ������������� ������ �����, ������ � �� ������ ����� ��������� ��������� ���� 
    /// </summary>
    public uint AuthorId { get; set; }
    /// <summary>
    /// ����� �������� �����
    /// </summary>
    public DateTime Time { get; set; }
    /// <summary>
    /// ���������� �����
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// ���������� ��������
    /// </summary>
    public uint RepostCount { get; set; }
    /// <summary>
    /// ���������� ������
    /// </summary>
    public uint LikeCount { get; set; }
    /// <summary>
    /// ���������� ����������
    /// </summary>
    public uint ViewCount {  get; set; }
    /// <summary>
    /// (id, authorId) ��������� �� ���� �� ������� ��������, ���� id == 0, ������ ��������������� ����, � �� �����������
    /// </summary>
    public (uint, uint) MotherPost {  get; set; }
    
}

class PostCounter
{
    public uint AuthorId { get; set; }
    public uint PostCount {  get; set; }
}
