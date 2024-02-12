#include <iostream>
#include <string>
#include <windows.h>
#include <fstream> 
using namespace std ;


//globals variables ;
bool isWin = false ;
int gameCount ;
int tableSize ;
int players ;
int rowSize ;
int indexA = -1;
bool winerFlag = false;
bool tieFlag = false ;
int numberMovement ;
int startPlace;
int startPlaceDiagonal;
int numberOfRound = 0;


// players strings
string playersName [4];
char* row1 = new char [tableSize] ;
char* row2 = new char [tableSize] ;
char signs[4] = {'X','O','H','S'};
int playersScore [4] = {0,0,0,0};

//advanced function

 int getInput(){
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

void error(int time){
	PlaySound(NULL , NULL , 0);
	cout<<"\a";
	system("Color 04");
	Sleep(time);
	PlaySound( "music\\music.wav", NULL , SND_FILENAME | SND_ASYNC);
}

void setColor(){
	if(indexA == 0){
		system("Color B0");
	}else if(indexA == 1){
		system("Color 97");
	}else if(indexA == 2){
		system("Color 50");
	}else if(indexA == 3){
		system("Color 57");
	}
}

// game count & player count 

int howManyPlayer(){
	cout<<"Select number of players : "<<endl;
	cout<<"Two players => 2"<<endl;
	cout<<"three players => 3"<<endl;
	cout<<"Four players => 4"<<endl;
	
	int integer = getInput();
	while(integer >4 || integer < 2){
		system("CLS");
		cout<<"Select a number of these numbers : "<<endl;
		cout<<"Two players => 2"<<endl;
		cout<<"three players => 3"<<endl;
		cout<<"Four players => 4"<<endl;
		integer = getInput();
	}
	return integer ;
}

void howMuchGame(){
	cout<<"How much do you want to play ?"<<endl;

	gameCount = getInput() ;
	while(gameCount<0 || gameCount>10){
		system("CLS");
		cout<<"Enter a number betwen 1 - 9 ."<<endl;
		gameCount = getInput() ;
	}
}

// table proses 

void initArrayTable(){
	string arrContent ;
	for (int i = 1 ; i<= tableSize ; i++){
		arrContent = to_string(i);
		arrContent = arrContent + "  ";

		row1[i-1] = arrContent[0];
		row2[i-1] = arrContent[1];
	}

}

void creatTable(){
	
	cout<<"Select size of your game board :"<<endl;
	cout<<"3x3 => 3"<<endl;
	cout<<"4x4 => 4"<<endl;
	cout<<"5x5 => 5"<<endl;
	int size = getInput() ;
	while(size >5 || size <3){
		system("CLS");
		cout<<"Select a number between 3 - 5 : "<<endl;
		cout<<"3x3 => 3"<<endl;
		cout<<"4x4 => 4"<<endl;
		cout<<"5x5 => 5"<<endl;
		size = getInput() ;
	}

	tableSize = size*size ;
	rowSize = size ;
	initArrayTable();
}

void starRowsPrint(int s){
	cout<<"       ";
	for(int sh= 0 ; sh< (((s+2)*4)+(s+1) );sh++){
		cout<<'*';
		}
	cout<<endl;
}

void emptyRows(int size){
	cout<<"       *   ";
	int newSize = ((size+1)*4)+(size-3);
	for(int i = 0 ; i<newSize; i++){
		if(i%5 == 0){
			cout<<'|';
		}else{
			cout<<'-';
		}
	}
	cout<<"   *"<<endl;
}

void printTable(){
	cout<<"\n\n\n\n";
	starRowsPrint(rowSize);
	emptyRows(rowSize);
	cout<<"       *   | ";
	for(int i = 0 ; i<tableSize ; i++){
		cout<<row1[i]<<row2[i]<<" | ";
		
		if((i+1)%rowSize == 0 && (i+1)!= tableSize){
			cout<<"  *"<<endl;
			emptyRows(rowSize);
			cout<<"       *   | ";
		}else if((i+1)== tableSize){
			cout<<"  *"<<endl;
		}
		
	}
	emptyRows(rowSize);
	starRowsPrint(rowSize);
	cout<<"\n\n";
}

// winner function 

bool setIndexPlace(){
	int correctRow = numberMovement-1 ;
	if(row1[correctRow] == signs[indexA] && row1[correctRow+1]== signs[indexA]  && row1[correctRow+2] == signs[indexA] ){
		startPlace = correctRow ;
		return true;
	}
	if(row1[correctRow-1] == signs[indexA] && row1[correctRow]== signs[indexA]  && row1[correctRow+1] == signs[indexA] ){
		startPlace = correctRow-1 ;
		return true;
	}
	if(row1[correctRow-2] == signs[indexA] && row1[correctRow-1]== signs[indexA]  && row1[correctRow] == signs[indexA]  ){
		startPlace = correctRow-2 ;
		return true;
	}
	return false ;
}

bool rowCheck(){
	int correctRow = numberMovement-1 ;

	if(row1[correctRow] == row1[correctRow+rowSize] && row1[correctRow+rowSize] == row1[correctRow+(rowSize*2)] && row1[correctRow] == signs[indexA] ){
		return true;
	}
	if(row1[correctRow-rowSize] == row1[correctRow] && row1[correctRow]  == row1[correctRow+rowSize] && row1[correctRow] == signs[indexA]){
		return true;
	}
	if(row1[correctRow-(rowSize*2)] == row1[correctRow-rowSize] && row1[correctRow-rowSize] == row1[correctRow] && row1[correctRow] == signs[indexA] ){
		return true;
	}
	
	int startRow = (correctRow / (rowSize))*rowSize;
	int endRow = ((correctRow / (rowSize))*rowSize)+rowSize;
	
	if(setIndexPlace()){
		if(startPlace >= startRow && startPlace+rowSize <= endRow){
			return true;		
		}
	}
	
	return false ;
}

bool diagonalCheck(){
	int f1,f2,f3;
	int f1Place , f2Place , f3Place;
	for(int i = 0 ;i<tableSize ; i++){
		f1 = i;
		f2 = i+rowSize+1;
		f3 = i+(rowSize*2)+2;
		if(row1[f1] == row1[f2] && row1[f2] == row1[f3]){
			f1Place = f1%rowSize ;
			f2Place = f2%rowSize ;
			f3Place = f3%rowSize ;
			
			if(f1Place != rowSize-1 && f3Place != 0 ){
				return true ;
			}
		}
	}
	for(int i = 0 ;i<tableSize ; i++){
		f1 = i;
		f2 = i+rowSize-1;
		f3 = i+(rowSize*2)-2;
		if(row1[f1] == row1[f2] && row1[f2] == row1[f3] && row1[f1] == signs[indexA]){
			f1Place = f1%rowSize ;
			f2Place = f2%rowSize ;
			f3Place = f3%rowSize ;
			if(f1Place != 0 && f3Place != rowSize-1 ){
				return true ;
			}
		}
	}
	return false ;
}

void winerCheck(){
	if(rowCheck() || diagonalCheck()){
		winerFlag = true ;
	}else{
		winerFlag = false ;
	}
}

void checkTie(){
	tieFlag = false ;
	if(numberOfRound == tableSize){
		tieFlag = true ;
	}
}

void printWinner(){
	playersScore[indexA]++;
	cout<<"\n\n\n\n";
	system("Color 0A");
	printTable();

	cout<<"  $$$$$$$$$$$------------------ wow "<<playersName[indexA]<<" you are winner--------------------$$$$$$$$$$$ "<<endl;
}

void printTie(){
	cout<<"\n\n\n\n\n\n\n";
	system("Color 0C");
	printTable();
	cout<<"*----------------------------- the game was tied -----------------------*";
}

// players function 

void selectedSigns(){
	cout<<"This sign selected : "<<signs[0]<<"  |  "<<signs[1]<<"  |  "<<signs[2]<<"  |  "<<signs[3]<<endl;
}

bool checkSign(char signChanged){
	for(int i = 0 ; i < 4; i++){
		if(signs[i] == signChanged){
			return false ;
		}
	}
	return true ;
}

void changeSign (int indexSign){
	cout<<"\n\nThis is your sign => "<<signs[indexSign]<<" do you want to change your sign ? "<<endl<<"Yes = 1   No = else"<<endl;
	bool signFlag ;
	int confrimCheck = getInput();
	if(confrimCheck ==1){
		system("CLS");
		selectedSigns();
		cout<<"enter your sign from keyboard : ";
		char sign ;
		cin>>sign;
		signFlag = checkSign(sign);
		while(!signFlag){
			system("CLS");
			error(1000);
			selectedSigns();
			cout<<"this sign "<<sign<<" selected please select an other sign : ";
			cin>>sign;
			signFlag = checkSign(sign);
		}
		
	signs[indexSign] = sign ;
	cout<<"your sign chenged ."<<endl;
	Sleep(500);
	}
	system("CLS");
}

void getPlayersName(){
	for (int i =0 ; i<players ; i++){
		cout<<"Enter your name player "<<i+1<<" : \n";
		getline(cin,playersName[i]);
		if(playersName[i] == ""){
			getline(cin,playersName[i]);	
		}
		changeSign(i);
	}

}

void printPlayerName(){
	for (int i = 0 ; i<players ; i++){
		cout<<"player  "<<i+1<<"  is => "<<playersName[i]<<"  sign  => "<<signs[i]<<"                   Score : "<<playersScore[i]<<endl;	
	}
}

// player round && movement

void printRound(){
	if(indexA == players){
		indexA = 0;
	}
	cout<<"this is round of "<<playersName[indexA]<<" => ";
	cout<<signs[indexA]<<" : "<<endl;
}

bool checkPlace(int moveInt){
	bool forCheck = true ;
	int i = moveInt-1;
		if(row1[i]== signs[0] ||row1[i]== signs[1] ||row1[i]== signs[2] ||row1[i]== signs[3]){
			forCheck = false ;
		}

	return forCheck ;
}

void intTable(int indexMovement){
	row1[indexMovement-1] = signs[indexA];
	row2[indexMovement-1] = ' ';
	numberOfRound++;
}

void getPlayerMovement(){
	cout<<"Choose your nut movement : ";
	numberMovement = getInput();
	bool check ;
	if(numberMovement>0 && numberMovement<tableSize+1){
		check = checkPlace(numberMovement);
		
		if(check){
			intTable(numberMovement );
			winerCheck();
			checkTie();
		}else{
			cout<<"Error round chenged ! you should select an empty nut"<<endl;
			error(2000);
		}
		
	}else{
		cout<<"Error round chenged ! you should enter a number between 1-"<<tableSize<<endl;
		error(2000);
	}
			
}

//rest variabels 

void resetValue(){
	winerFlag = false;
	tieFlag = false ;
	indexA = -1;
	initArrayTable();
}

// main game function 

void runGame(){
	system("CLS");
	system("Color B0");
	getPlayersName();
	howMuchGame() ;
	system("CLS");
	creatTable();
	while (gameCount > 0 ){
		PlaySound( "music\\music.wav", NULL , SND_FILENAME | SND_ASYNC);
		while(!winerFlag && !tieFlag){
			system("CLS");
			indexA++;
			printPlayerName();
			printTable();
			printRound();
			setColor();
			getPlayerMovement();
			system("CLS");
		}
		gameCount--;
		cout<<"Game over ...";
		if(winerFlag){
			printWinner();
		}else{
			printTie();
		}
		
		Sleep(2000);
		resetValue();
	}
}

//main function 

int main(){
	players = howManyPlayer();
	if(players >= 2 && players<=4  ){
		runGame();
	}else{
		cout<<"Error you should enter a Number between 1-2 ."<<endl<<"Game Over ."<<endl;
	}
	
}     