using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public interface IUser
    {
        string GetLogin();
        void SetRating(int point);
        string WriteMessage(string message);
    }
}
