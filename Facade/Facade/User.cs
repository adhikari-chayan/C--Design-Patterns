using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
   public class User
    {
        private List<User> _followers = new List<User>();//my followers

        public string UserName { get; set; }

        public bool Follow(User userToFollow)
        {
            //code for adding follower
            return true;
        }

        public bool FollowerAdded(User newFollower)
        {
            //code for notifying user that he has a new follower
            Notification notification = new Notification();
            return notification.NotifyUser(this, newFollower.UserName + " is now following you!");
        }

        public bool FollowingTextPost(User userToFollow)
        {
            //code for posting simple text
            Post post = new Post();
            return post.PostText(this, this.UserName + " is now following "+ userToFollow.UserName);
        }

        public bool NotifyFollowers(User userToFollow)
        {
            bool result = true;
            Notification notification = new Notification();

            foreach(User user in _followers)
            {
                //code for notifying followers of new activity
                result = notification.NotifyUser(user, this.UserName + " is now following " + userToFollow.UserName);
                if (!result)
                    break;
            }
            return result;
        }

    }
}
