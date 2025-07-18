//The challenge says it should be hardcoded, but im too lazy for that. So im just using Read, parses, loops.

const int studentQuantity = 4;
string[] students = new string[studentQuantity];
int[] grades = new int[5];
double[] finalScore = new double[studentQuantity];
int scoreSum = 0;

for (int i=0; i<studentQuantity; i++) {
    Console.Write("Student: ");
    students[i] = Console.ReadLine();
    for (int j=0; j<5; j++) {
        Console.Write($"E{j+1}: ");
        grades[j] = int.Parse(Console.ReadLine());
        scoreSum += grades[j];
    }
    double averageScore = scoreSum / (double)5;
    finalScore[i] = averageScore;

    scoreSum = 0;
    
    Console.WriteLine();
    Console.WriteLine();
}


//output
Console.WriteLine("Student\t\t\tGrade");
Console.WriteLine();
for (int i=0; i<studentQuantity; i++) {
    Console.WriteLine($"{students[i]}:\t\t\t{finalScore[i]}\t{classifyScore(finalScore[i])}");
}




string classifyScore(double score) {
    string classification = "";

    //I hate it
    if (score < 59) {
        classification = "F";
    }
    else if (score >= 60 && score <= 62) {
        classification = "D-";
    }
    else if (score >= 63 && score <= 66) {
        classification = "D";
    }
    else if (score >= 67 && score <= 69) {
        classification = "D+";
    }
    else if (score >= 70 && score <= 72) {
        classification = "C-";
    }
    else if (score >= 73 && score <= 76) {
        classification = "C";
    }
    else if (score >= 77 && score <= 79) {
        classification = "C+";
    }
    else if (score >= 80 && score <= 82) {
        classification = "B-";
    }
    else if (score >= 83 && score <= 86) {
        classification = "B";
    }
    else if (score >= 87 && score <= 89) {
        classification = "B+";
    }
    else if (score >= 90 && score <= 92) {
        classification = "A-";
    }
    else if (score >= 93 && score <= 96) {
        classification = "A";
    }
    else if (score > 96) {
        classification = "A+";
    }
   

    return classification;
}


