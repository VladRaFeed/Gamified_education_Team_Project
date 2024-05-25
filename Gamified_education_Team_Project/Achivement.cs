using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    class Achivement
    {
        private string achivementId;
        private string achivementName;
        private bool achivementComplete;

        public Achivement(string achivementId, string achivementName, bool achivementComplete)
        {
            this.achivementId = achivementId;
            this.achivementName = achivementName;
            this.achivementComplete = achivementComplete;
        }

        public string AchivementId
        {
            get => this.achivementId;
        }

        public string AchivementName
        {
            get => this.achivementName;
        }

        public bool AchivementComplete
        {
            get => this.achivementComplete;
            set => this.achivementComplete = value;
        }
    }
}
