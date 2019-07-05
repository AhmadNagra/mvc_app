#include <iostream>
using namespace std;



class myClass{
	public :
		myClass (){
			
		}
virtual	 void  myfunc(){
			cout<<"Hello";			
		}
};

class secondClass : public myClass{
	
	public:
		secondClass(){
		}
		
	void myfunc(){
			myClass::myfunc();
			cout<<"World";
		}
};

int main(){
	myClass *X=new secondClass();
	X->myfunc();
}
