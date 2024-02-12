#include <iostream>
#include <string>
#include <windows.h>
#include <fstream> 
using namespace std ;


//global variables
char array[9]= {'1','2','3','4','5','6','7','8','9'};
string playersName [2] ;
bool winerFlag = false ;
bool tieFlag = false ;
char signs[2] = { 'X' , '0'};
int moveMentCount = 0;
int indexRound = -1 ;
int playersScore [2] = {0,0};


//advance function

void resetValue(){
	winerFlag = false ;
	tieFlag = false ;
	moveMentCount = 0;
	indexRound = -1 ;
	for(int i = 0 ; i<9 ; i++){
		char charNumber = i+49; 
		array[i]= charNumber;
	}
}

int getNumber(){
	string inputStr ;
	bool bolCheck = true ;
	cin>>inputStr;
	int realInp ;
	for(int iN = 0 ; iN < inputStr.length() ; iN++){
		if(!isdigit(inputStr[iN])){
			bolCheck = false;
		}
	}
	if(bolCheck){
		realInp = stoi(inputStr);
	}else{
		realInp = 10000;
	}
	
	return realInp ;
}

bool playAgain(){
	system("CLS");
	cout<<"\n\n\n\n\n\n\n";
	cout<<"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"<<endl;
	cout<<"^  Do you want to play again ? ^"<<endl;
	cout<<"^  1 : Yes    other key : Exit ^"<<endl;
	cout<<"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"<<endl;
	int playAgainInp = getNumber()  ;
	if(playAgainInp == 1){
	return true;
	}
	return false ;
}

void setColor(){
	if(indexRound == 0){
		system("Color B0");
	}else{
		system("Color 57");
	}
}

//  players function

void getNamePlayers() {
	system("Color 03");
	string name;
	for(int  i = 0 ; i<2  ; i++){
		cout<<"\n";
		cout<<"   Enter name of player  "<<i+1<<"  :    ";
		getline(cin,name);
		if(name == ""){
			getline(cin,name);	
		}
		playersName[i] = name ;
	}
	
}

void chapPleyarName() {
	cout<<"\n\n\n";
	cout<<"                    Player 1 : "<<playersName[0]<<" => X    Score : "<<playersScore[0]<<endl;
	cout<<"                    Player 2 : "<<playersName[1]<<" => 0    Score : "<<playersScore[1]<<endl;
	cout<<endl;
}

// table function

bool fillCheck(int index){
	if(array[index] != '0' && array[index] != 'X') {
		return false ;
	}
	return true ;
}

void initMovement() {
	int moveMent = getNumber();
	if((moveMent > 9 || moveMent < 0) || fillCheck(moveMent-1)) {
		cout<<"\a";
		cout<<"You should enter a number between 1-9 & select an empty nut ! round chenged ."<<endl;
		PlaySound(NULL , NULL , 0);
		cout<<"\a";
		Sleep(2000);
		PlaySound("music\\music.wav", NULL , SND_FILENAME | SND_ASYNC);
		}else{
			array[moveMent-1] = signs[indexRound];
			moveMentCount++;	
		}
}

void printTable() {
	cout<<"\n\n\n";
	cout<<"                    #################################"<<endl;
	cout<<"                    # *        DOZ PROJECT        * #"<<endl;
	cout<<"                    #   *                       *   #"<<endl;
	cout<<"                    #     *###################*     #"<<endl;
	cout<<"                    #     #                   #     #"<<endl;
	cout<<"                    #     #  "<<array[0]<<"  |   "<<array[1]<<"   |  "<<array[2]<<"  #     #"<<endl;
	cout<<"                    #     #-----|-------|-----#     #"<<endl;
	cout<<"                    #     #  "<<array[3]<<"  |   "<<array[4]<<"   |  "<<array[5]<<"  #     #"<<endl;
	cout<<"                    #     #-----|-------|-----#     #"<<endl;
	cout<<"                    #     #  "<<array[6]<<"  |   "<<array[7]<<"   |  "<<array[8]<<"  #     #"<<endl;
	cout<<"                    #     #                   #     #"<<endl;
	cout<<"                    #     *###################*     #"<<endl;
	cout<<"                    #   *                       *   #"<<endl;
	cout<<"                    # *       HAMED FAKOORI       * #"<<endl;
	cout<<"                    #################################"<<endl;
	cout<<"\n\n\n";
}

// round function

void round() {
	indexRound++;
	if(indexRound ==2){
		indexRound = 0 ;
	}
}

void chapRound () {
		setColor();
		cout<<"                         this is round of "<<playersName[indexRound]<<" => "<<signs[indexRound]<<" : ";
}

//winner function 

void winner() {
	if(array[0] == array[1] && array[1] ==array[2]) {
		winerFlag = true ;
	} else if(array[3] == array[4] && array[4] ==array[5]) {
		winerFlag = true ;
	} else if(array[6] == array[7] && array[7] ==array[8]) {
		winerFlag = true ;
	} else if(array[0] == array[4] && array[4] ==array[8]) {
		winerFlag = true ;
	} else if(array[2] == array[4] && array[4] ==array[6]) {
		winerFlag = true ;
	} else if(array[0] == array[3] && array[3] ==array[6]) {
		winerFlag = true ;
	} else if(array[1] == array[4] && array[4] ==array[7]) {
		winerFlag = true ;
	} else if(array[2] == array[5] && array[5] ==array[8]) {
		winerFlag = true ;
	}

	if(moveMentCount == 9) {
		tieFlag= true ;
	}
}

void chapWiner() {
	chapPleyarName();
	printTable();
	if(winerFlag) {
		system("Color 0A");
		cout<<"                    --------------*  wow  winner  is  :  "<<playersName[indexRound]<<"  *---------------"<<endl;

	} else {
		system("Color 40");
		cout<<"                    ----------*     "<<playersName[0]<<" and "<<playersName[1]<<" are both winners    *------------";
	}
	Sleep(4000);
}

int main() {
	bool playAgainCheck = true ;
	getNamePlayers();
	while(playAgainCheck){
		PlaySound( "music\\music.wav", NULL , SND_FILENAME | SND_ASYNC);
		while(!winerFlag && !tieFlag) {
			system("CLS");
			round();
			chapPleyarName();
			printTable();
			chapRound();
			initMovement();
			winner();
		}
		if(winerFlag){
			playersScore[indexRound]++;
		}
		system("CLS");
		chapWiner();
		playAgainCheck = playAgain();
		resetValue();
	}
}