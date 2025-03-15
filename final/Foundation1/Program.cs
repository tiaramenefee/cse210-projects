using System;

class Program
{
    static void Main(string[] args)
    {
    

    
    Video video1 = new Video();
    video1._title = "How To Sew a Classic Tote Bag - No Overlocker Needed! Beginner Friendly Project";
    video1._author = "Rosie Caldwell";
    video1._length = 578;  
    video1.AddComment(new Comment("Maria L", "Thank you for the tutorial. I am a beginner and look forward to starting on sowing the bag."));
    video1.AddComment(new Comment("Lina G", "Such a wonderful job, neat and precise. You are inspiring!"));

        

    Video video2 = new Video();
    video2._title = "Exploring every Island in Hawaii";
    video2._author = "Outdoor Boys";
    video2._length = 10964;  
    
        

    Video video3 = new Video();
    video3._title = "Come follow me Doctine and Covenants Sections 20-22(Mar.10-16) Don't Miss This";
    video3._author = "Don't Miss this";
    video3._length = 1800;  
    video3.AddComment(new Comment("Steven M", "I love what you have shared. Sometimes, we can feel overwelmed by life. Its a great reminder that we are not doing this alone. We can ask God. Thank you!"));
    video3.AddComment(new Comment("Rebecca E", "We believe in a God that cares about things that we care about. Love that!"));

    video1.DisplayVideoWithComments(); 
    video3.DisplayVideoWithComments(); 

    }
}