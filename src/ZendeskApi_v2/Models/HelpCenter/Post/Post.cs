﻿using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.HelpCenter.Post
{
    public class Post : HelpCenterBase
    {
        /// <summary>
        /// The title of the post
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The details of the post
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// The id of the author of the post.
        /// </summary>
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }

        /// <summary>
        /// When true, pins the post to the top of its topic
        /// </summary>
        [JsonProperty("pinned", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Whether the post is featured
        /// </summary>
        [JsonProperty("featured", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Featured { get; set; }

        /// <summary>
        /// Whether further comments are allowed
        /// </summary>
        [JsonProperty("closed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Closed { get; set; }

        //TODO: Convert to enum 
        /// <summary>
        /// The status of the post. Possible values: "planned", "not_planned" , "answered", or "completed"
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The total sum of votes on the post
        /// </summary>
        [JsonProperty("vote_sum")]
        public int VoteSum { get; set; }

        /// <summary>
        /// The number of votes cast on the post
        /// </summary>
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// The number of comments on the post
        /// </summary>
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        /// <summary>
        /// The number of followers of the post
        /// </summary>
        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }

        /// <summary>
        /// The id of the topic that the post belongs to
        /// </summary>
        [JsonProperty("topic_id")]
        public long TopicId { get; set; }
    }
}
