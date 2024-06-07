using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        [HttpGet("userinfo")]
        public IActionResult GetUserInfo()
        {
            // Retrieve user information from claims
            var name = User.Identity?.Name;
            var section = User.FindFirst("section")?.Value;
            var course = User.FindFirst("course")?.Value;

            // Create a dictionary to hold user information
            var userInfo = new Dictionary<string, string>
            {
                { "Name", name },
                { "Section", section },
                { "Course", course }
            };

            return Ok(userInfo);
        }

        [HttpGet("funfacts")]
        public IActionResult GetFunFacts()
        {
            // Fun facts about the API creator
            var funFacts = new List<string>
            {
                "I'm a big fan of sushi!",
                "I love playing the guitar.",
                "I've visited over 10 countries.",
                "I'm a certified scuba diver.",
                "I enjoy hiking in the mountains.",
                "I'm passionate about machine learning.",
                "I'm fluent in three languages.",
                "I have a pet dog named Luna.",
                "I'm a coffee enthusiast.",
                "I enjoy reading science fiction novels."
            };

            return Ok(funFacts);
        }
    }
}
