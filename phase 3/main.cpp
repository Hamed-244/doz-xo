#include <iostream>
#include <string>
#include <windows.h>
#include <fstream>
#include <thread>
using namespace std ;


//global variables
char arr[9]= {'1','2','3','4','5','6','7','8','9'};
string playersName [2]; ;
int  indexPlayer = -1 ;
bool winerFlag = false ;
bool tieFlag = false ;
bool Coumputer ;
int moveMent ;
char signs [2] = {'X' , '0'};
int moveMentCount = 0;
int playersScore[2] = {0 , 0};
bool 	isActive = true ;

//advance function 

void resetValue() {
	indexPlayer = -1 ;
	winerFlag = false ;
	tieFlag = false ;
	system("Color 03");
	moveMentCount = 0;
	for(int i = 0 ; i<9 ; i++) {
		char charNumber = i+49;
		arr[i] = charNumber;
	}
}

int getNumber() {
	string inputStr ;
	bool bolCheck = true ;
	cin>>inputStr;
	int realInp ;
	for(int iN = 0 ; iN < inputStr.length() ; iN++) {
		if(!isdigit(inputStr[iN])) {
			bolCheck = false;
		}
	}
	if(bolCheck) {
		realInp = stoi(inputStr);
	} else {
		realInp = 10000;
	}

	return realInp ;
}

bool playAgain() {
	system("CLS");
	cout<<"\n\n\n\n\n\n\n";
	system("Color A0");
	cout<<"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"<<endl;
	cout<<"^  Do you want to play again ? ^"<<endl;
	cout<<"^  1 : Yes    other key : Exit ^"<<endl;
	cout<<"^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"<<endl;
	int playAgainInp = getNumber()  ;
	if(playAgainInp == 1) {
		return true;
	}
	return false ;
}

void Error(int time){
	PlaySound(NULL, NULL, 0);
	cout<<"\a";
	Sleep(time);
	PlaySound("music\\music.wav", NULL, SND_FILENAME | SND_ASYNC);
}

//  players function
void getNamePlayers(int count) {
	string name;
	cout<<"\n";
	cout<<"Enter name of player "<<count<<"  :    ";
	getline(cin,name);
	if (name ==""){
		getline(cin,name);	
	}
	playersName[count-1] = name;

}

void chapPleyarName() {
	cout<<"\n\n\n";
	cout<<"                    Player 1 : "<<playersName[0]<<" => X    Score : "<<playersScore[0]<<endl;
	cout<<"                    Player 2 : "<<playersName[1]<<" => 0    Score : "<<playersScore[1]<<endl;
	cout<<endl;
}

//Coumputer function

bool  winner() {
	winerFlag = false ;
	if(arr[0] == arr[1] && arr[1] ==arr[2]) {
		winerFlag = true ;
	} else if(arr[3] == arr[4] && arr[4] ==arr[5]) {
		winerFlag = true ;
	} else if(arr[6] == arr[7] && arr[7] ==arr[8]) {
		winerFlag = true ;
	} else if(arr[0] == arr[4] && arr[4] ==arr[8]) {
		winerFlag = true ;
	} else if(arr[2] == arr[4] && arr[4] ==arr[6]) {
		winerFlag = true ;
	} else if(arr[0] == arr[3] && arr[3] ==arr[6]) {
		winerFlag = true ;
	} else if(arr[1] == arr[4] && arr[4] ==arr[7]) {
		winerFlag = true ;
	} else if(arr[2] == arr[5] && arr[5] ==arr[8]) {
		winerFlag = true ;
	}

	if(moveMentCount == 9) {
		tieFlag = true ;
	}
	return winerFlag;
}

int minimax( int depth, bool isAI , int signIndex) {
	int score = 0;
	int bestScore = 0;
	if(signIndex == 2){
		signIndex = 0;
	}
	if (winner()) {
		if (isAI ) {
			return -1;
		}
		if (!isAI) {
			return +1;
		}
	} else {
		if(depth < 9) {
			if(isAI == true) {
				bestScore = -999;
				for(int i=0; i<9; i++) {
					if (arr[i]!= 'X'&& arr[i]!='0') {
						arr[i] = signs[signIndex];
						
						score = minimax( depth + 1, false , signIndex+1);
						arr[i] = i+49;
						if(score > bestScore) {
							bestScore = score;
						}
					}
				}
				return bestScore;
			} else {
				bestScore = 999;
				for (int i = 0; i < 9; i++) {
					if (arr[i]!= 'X'&& arr[i]!='0') {
						arr[i] = signs[signIndex];
						score = minimax( depth + 1, true , signIndex+1);
						arr[i] = i+49;
						if (score < bestScore) {
							bestScore = score;
						}
					}
				}
				return bestScore;
			}
		} else {
			return 0;
		}
	}
	return 0;
}

int bestMove( int moveIndex) {
	int x = -1;
	int score = 0, bestScore = -999;
	for (int i = 0; i < 9; i++) {
		if (arr[i]!= 'X'&& arr[i]!='0') {
			arr[i] = signs[indexPlayer];
			score = minimax( moveIndex+1, false , indexPlayer+1);
			arr[i] = i+49;
			if(score > bestScore) {
				bestScore = score;
				x = i;
			}
		}
	}
	return x;
}

// table function

void runThread(){
	isActive = true ;
	thread get([&]{
		moveMent = getNumber();
		isActive = false ;
	});
	
	int count = 0 ;
	while(isActive && count < 300){
		Sleep(10);
		count++; 
	}

	get.detach();
}

bool fillCheck(int index) {
	if(arr[index] != '0' && arr[index] != 'X') {
		return true ;
	}
	return false ;
}

void initMovement() {
	if(playersName[indexPlayer] != "Coumputer") {
		moveMent = 123;
		runThread();
		if(moveMent != 123){
			if((moveMent > 9 || moveMent <1) || !fillCheck(moveMent-1)) {
				cout<<endl<<"          You should enter a number between 1-9 & select an empty nut ! round chenged .";
				Error(2000);
			} else {
				arr[moveMent-1] = signs[indexPlayer];
				moveMentCount++;
			}
		}else{
			cout<<endl<<"          Your time finished ! round will change .";
			Error(1500);
		}
		
	} else {
		int placeIndex = bestMove(moveMentCount);
		arr[placeIndex] = signs[indexPlayer];
		Sleep(1000);
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
	cout<<"                    #     #  "<<arr[0]<<"  |   "<<arr[1]<<"   |  "<<arr[2]<<"  #     #"<<endl;
	cout<<"                    #     #-----|-------|-----#     #"<<endl;
	cout<<"                    #     #  "<<arr[3]<<"  |   "<<arr[4]<<"   |  "<<arr[5]<<"  #     #"<<endl;
	cout<<"                    #     #-----|-------|-----#     #"<<endl;
	cout<<"                    #     #  "<<arr[6]<<"  |   "<<arr[7]<<"   |  "<<arr[8]<<"  #     #"<<endl;
	cout<<"                    #     #                   #     #"<<endl;
	cout<<"                    #     *###################*     #"<<endl;
	cout<<"                    #   *                       *   #"<<endl;
	cout<<"                    # *       HAMED FAKOORI       * #"<<endl;
	cout<<"                    #################################"<<endl;
	cout<<"\n\n\n";
}

// round function

void round() {
	indexPlayer++;
	if(indexPlayer == 2){
		indexPlayer = 0 ;
	}
}

void chapRound () {
	cout<<"                         this is round of "<<playersName[indexPlayer]<<" => "<<signs[indexPlayer]<<" : ";
	if(!Coumputer){
		cout<<"(suggest : "<<bestMove(moveMentCount)+1<<") : ";
	}
}

//winner function

void chapWiner() {
	chapPleyarName();
	printTable();
	if(winerFlag) {
		system("Color 0A");
		cout<<"                    --------------*  wow  winner  is  :  "<<playersName[indexPlayer]<<"  *---------------"<<endl;
	} else {
		system("Color 40");
		cout<<"                    ----------*     "<<playersName[0]<<" and "<<playersName[1]<<" are both winners    *------------";
	}
	Sleep(4000);
}

void playWith(){
	cout<<"Do you want to play with Coumputer or your friend ? "<<endl;
	cout<<"Play with coumputer => 1"<<endl;
	cout<<"Play with friend => else"<<endl;
	int answer = getNumber();
	system("CLS");
	if(answer == 1){
		getNamePlayers(1);
		playersName[1] = "Coumputer";
		Coumputer = true ;
	}else{
		getNamePlayers(1);
		getNamePlayers(2);
		Coumputer = false ;
	}
}

void firstPlayer(){
	cout<<"Do you want to play first ?"<<endl;
	cout<<"Yes => 1 / No => else "<<endl;
	int answer = getNumber() ;
	if(answer != 1){
		playersName[0].swap(playersName[1]);
	}
}

int main() {
	PlaySound( "music\\music.wav", NULL, SND_FILENAME | SND_ASYNC);
	bool playAgainCheck = true ;
	system("Color 03");
	playWith();
	system("CLS");
	if(Coumputer){
		firstPlayer();	
	}
	while(playAgainCheck) {
		while(!winerFlag && !tieFlag) {
			round();
			system("CLS");
			chapPleyarName();
			printTable();
			chapRound();
			initMovement();
			winner();
		}

		playersScore[indexPlayer]++;

		system("CLS");
		chapWiner();
		playAgainCheck = playAgain();
		resetValue();
	}
}
