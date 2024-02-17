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
        /// ����� ��� ��������� ���� ������ ������������
        /// </summary>
        /// <param name="AuthorID">���� ������������ ��� ����� ������� ����������</param>
        /// <returns>������ ������ ������������</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetPostsAsync(uint AuthorID)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// �������� ��� ����������� � ����� ����������� 1
        /// </summary>
        /// <param name="AuthorID">���� ������ �����</param>
        /// <param name="PostId">���� �����</param>
        /// <returns>������ ������������(������) �����, ��� ������� �� �����������</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetCommentsAsync(uint AuthorID, uint PostId) 
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpPost]
        /// <summary>
        /// ����� ��� �������� �����
        /// </summary>
        /// <param name="AuthorId">���� ������</param>
        /// <param name="Text">����������� �����</param>
        /// <returns>Ok 201</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> CreatePost(uint AuthorId, string Text)
        {
            throw new NotImplementedException();
        }

        [Route("[action]")]
        [HttpGet]
        /// <summary>
        /// �������� ����� ��������
        /// </summary>
        /// <param name="FriendsId">���� ��������</param>
        /// <returns>������ ������ �������� �� ��������� ��� ���</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IActionResult> GetFeedAsync(uint[] FriendsId)
        {
            throw new NotImplementedException();
        }
    }
}
