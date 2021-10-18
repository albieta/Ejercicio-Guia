#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>


int main(int argc, char *argv[]) {
	
	char peticion[100];
	char resultado[100];
	
	strcpy (peticion, "Miguel/47/Juan/12/Maria/22/Marcos/19");
	// Resultado: "Miguel*47-Maria*22-Marcos*19"
	
	char nombre[20];
	int edad;
	char *p = strtok (peticion, "/");
	
	while(p!=NULL)
	{
		strcpy (nombre, p);
		p = strtok (NULL, "/");
		edad = atoi(p);
		if (edad > 18)
			sprintf(resultado, "%s%s*%d-", resultado, nombre, &edad);
		p = strtok (NULL, "/");
	}
	
	resultado [strlen(resultado)-1] = '\0';
	
	printf ("Resultado: %s\n", resultado);
	
	//RETO1
	
	char nombre2[20];
	char nombre2_inv[20];
	printf ("\nDime si mi nombre es palíndromo. Escribe tu nombre: \n");
	scanf("%s",nombre2);
	int counter = strlen(nombre2)-1;
	int a =0;
	while (a<strlen(nombre2))
	{
		nombre2[a] = tolower(nombre2[a]);
		nombre2_inv[a] = tolower(nombre2[counter]);
		counter = counter-1;
		a=a+1;
	}
	if (strcmp(nombre2,nombre2_inv)==0)
		printf("Tu nombre SI es palíndromo! %s = %s :)\n",nombre2,nombre2_inv);
	else
		printf("Tu nombre NO es palíndromo! %s != %s :(\n",nombre2,nombre2_inv);
	
	//RETO2

	char nombre3[20];
	printf("\nDevuélveme mi nombre en mayúsculas. Escribe tu nombre: \n");
	scanf("%s",nombre3);
	for(int r=0;r<strlen(nombre3);++r)
		nombre3[r] = toupper(nombre3[r]);
	printf("Tu nombre en mayúsculas es: %s\n",nombre3);
	
	
	
	return 0;
}

