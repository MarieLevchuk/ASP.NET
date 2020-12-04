using System;

namespace Blogging
{
    public class Blogger
    {
        public string Nickname { get; set; }
        public Blogger (string nickname)
        {
            Nickname = nickname;
        }

        public void CreateContent(ContentMaker content)
        {
            content.MakeContent();
        }
        /*Здесь с помощью абстрактного класса реализован второй из принципов SOLID. 
        Методы AddPhoto(), AddVideo(), АddText() можно изменять, не меняя структуру
        данного класса Blogger*/
    }
}
