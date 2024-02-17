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
        /// Get all post from user's wall
        /// </summary>
        /// <param name="AuthorID">wall owner</param>
        /// <returns>Array of the post by author sorted by descending order of time</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetPostsAsync(uint AuthorID)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// Get all the comments below the post
        /// </summary>
        /// <param name="AuthorID">Source post's author id</param>
        /// <param name="PostId">Source post id</param>
        /// <returns>Array of comments below thew post sorted by time</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetCommentsAsync(uint AuthorID, uint PostId) 
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpPost]
        /// <summary>
        /// Create post on the wall
        /// </summary>
        /// <param name="AuthorId">Post's author id</param>
        /// <param name="Text">Text of the post</param>
        /// <returns>Ok(201) - created</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> CreatePost(uint AuthorId, string Text)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// Get posts to feed
        /// </summary>
        /// <param name="FriendsId">Ids of subscriptions</param>
        /// <returns>Array of posts for the last 3 days</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetFeedAsync(uint[] FriendsId)
        {
            throw new NotImplementedException();
        }
    }
}
