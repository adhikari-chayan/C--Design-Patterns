using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
   public class Follower
    {
        public bool Follow(User follower,User following)
        {
            bool result;

            //add user as follower
            result = follower.Follow(following);
            if(!result)
            {
                return false;
            }

            //notify user that they have an added follower
            result = following.FollowerAdded(follower);

            //post that user is now following a new person
            result = follower.FollowingTextPost(following);
            if(!result)
            {
                return false;
            }

            //notify all of user's followers of new following activity
            result = follower.NotifyFollowers(following);
            if (!result)
            {
                return false;
            }

            return result;
        }
    }
}
