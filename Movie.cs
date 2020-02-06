using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    class Movie
    {
        private int catCount;
        private string title;
        private string category;
        private int runTime;
        private int yearReleased;

        public int CatCount { get => catCount; }
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        public int RunTime { get => runTime; set => runTime = value; }
        public int YearReleased { get => yearReleased; set => yearReleased = value; }

        public Movie(int catCount, string title, string category, int runTime, int yearReleased)
        {
            this.catCount = catCount;
            this.title = title;
            this.category = category;
            this.runTime = runTime;
            this.yearReleased = yearReleased;
        }

        public override string ToString()
        {
            return $"=========================================================================\n" +
                $"Movie: {title} " +
                $"\nCategory: {category} \tRuntime: {runTime} minutes \tYear Released: {yearReleased}" +
                $"\n=========================================================================\n";
        }
    }
}
