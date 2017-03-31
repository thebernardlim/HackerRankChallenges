class Student : Person{
    private int[] testScores;  
    
    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        testScores = scores;
    }
    
    public char Calculate(){
        int totalScore = 0;
        char mark =  ' ';
        
        foreach(int score in testScores){
            totalScore += score;
        }
        
        int averageScore = totalScore / testScores.Length;
        
        if (averageScore >= 90 && averageScore <= 100) mark = 'O';
        if (averageScore >= 80 && averageScore < 90) mark = 'E';
        if (averageScore >= 70 && averageScore < 80) mark = 'A';
        if (averageScore >= 55 && averageScore < 70) mark = 'P';
        if (averageScore >= 40 && averageScore < 55) mark = 'D';
        if (averageScore < 40) mark = 'T';
        
        return mark;
        
    }

}