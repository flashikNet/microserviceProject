using Microsoft.AspNetCore.Mvc;

namespace PostApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostApiController : ControllerBase
    {
        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// Метод для получения всех постов пользователя
        /// </summary>
        /// <param name="AuthorID">Айди пользователя чьи посты хочется посмотреть</param>
        /// <returns>Список постов пользователя</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetPostsAsync(uint AuthorID)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// Получить все комментарии к посту вложенности 1
        /// </summary>
        /// <param name="AuthorID">Айди автора поста</param>
        /// <param name="PostId">Айди поста</param>
        /// <returns>Список комментариев(постов) поста, без ответов на комментарии</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetCommentsAsync(uint AuthorID, uint PostId) 
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpPost]
        /// <summary>
        /// Метод для создания поста
        /// </summary>
        /// <param name="AuthorId">Айди автора</param>
        /// <param name="Text">Наполенение поста</param>
        /// <returns>Ok 201</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> CreatePost(uint AuthorId, string Text)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// Получить ленту новостей
        /// </summary>
        /// <param name="FriendsId">Айди подписок</param>
        /// <returns>Список постов подписок за последние три дня</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetFeedAsync(uint[] FriendsId)
        {
            throw new NotImplementedException();
        }
    }
}
