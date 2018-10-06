#include <stdio.h>
// #include <cs90.h>
int main(void) {
	
	int height = 5
	
//	while(height < 0 || height>23)  {
//	  print("Enter height betwen 0 - 23:  ");
//	  height = get_int();
//	}
    //row
	for (int row = 0; row < height; row++) {
		
		//print spaces
		for (int spaces = 0; space < (height - row - 1); spaces++){
			print (" ");
		}
		for (int hashes = 0; hashes < (row +2) ;hashes++) {
			print("#");
		}
		
		print("/n");
	}
}