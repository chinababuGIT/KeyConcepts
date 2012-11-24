#include <iostream>
#include <exception>

namespace CPPReview
{
	class abstractClass
	{
	
	};

	class childClass1 : public abstractClass
	{
	
	
	};

	class childClass2 : protected abstractClass
	{
	
	};

	class AutoMethod
	{
	private:
		int* someArray;
	public:
		
		AutoMethod()
		{
			someArray = new int[100];
			std::cout<<"AutoMethod Constructor called"<<std::endl;
		}
		~AutoMethod()
		{
			std::cout<<"AutoMethod descturctor called"<<std::endl;
		}

		AutoMethod(const AutoMethod& copyFrom)
		{
			if(this != &copyFrom)
			{
				std::cout<<"AutoMethod copy constructor called"<<std::endl;
				int length = sizeof(copyFrom.someArray)/sizeof(int);
				int* tempArray = new int[length];
				for(int i=0;i <length;i++)
					tempArray[i]=copyFrom[i];
				
				//now do the copy without altering the old state
				try{
					for(int i=0; i< length;i++)
						someArray[i]=tempArray[i];
				}
				catch(except e)
				{
				
				}
				delete [] tempArray;

			}
			{
				return *this;
			}
		}




	}

};
	int main(std::string argument )
	{

		return 0;
	}