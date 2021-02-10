using System;
using System.Text;

namespace Exercise2 {
    public class Post {
        private int dashLine = 50;
        private string Title;
        private string Desc;
        private DateTime CreatedAt;
        private int UpVotes = 0;
        private int DownVotes = 0;

        public Post() {
            CreatedAt = DateTime.Now;
        }
        public Post(string title, string desc, DateTime createAt) {
            Title = title;
            Desc = desc;
            CreatedAt = createAt;
        }

        public void AddTitle(string title) {
            if(String.IsNullOrEmpty(Title)) {
                Title = title;
            }
        }

        public void AddDesc(string desc) {
            if(String.IsNullOrEmpty(Desc)){
                Desc = desc;
            }
        }

        public void AddUpVote() {
            UpVotes++;
        }

        public void RemoveUpVotes() {
            UpVotes--;
        }

        public void AddDownVote() {
            DownVotes++;
        }

        public void RemoveDownVote() {
            DownVotes--;
        }

        public StringBuilder DisplayInfo() {
            StringBuilder info = new StringBuilder();
            info.Append('-', dashLine);
            info.AppendLine();
            info.Append(Title);
            info.AppendLine();
            info.Append('-', dashLine);
            info.AppendLine();
            info.AppendLine();
            info.Append(Desc);
            info.AppendLine();
            info.AppendLine();
            info.AppendLine();
            info.AppendLine();
            info.Append('-', dashLine);
            info.AppendLine();
            info.Append(CreatedAt + "\t\t" + UpVotes + " Up Votes " + DownVotes + " Down Votes");

            return info;
        }
    }   
}