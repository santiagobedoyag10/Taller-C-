//PUNTO 1
Console.WriteLine("Ingrese el numerador de la fraccion #1");
float numerador1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el denominador de la fraccion #1");
float denominador1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese operador");
String operador = Console.ReadLine();
Console.WriteLine("Ingrese el numerador de la fraccion #2");
float numerador2 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el denominador de la fraccion #2");
float denominador2 = float.Parse(Console.ReadLine());
float resultadonumerador;
float resultadodenominador;

if(operador=="+"){
    if(denominador1==denominador2){
        resultadonumerador=numerador1+numerador2;
        Console.WriteLine("El Resultado de la suma es = " + resultadonumerador + "/" + denominador1);
    }
    else{
        float suma1= numerador1 * denominador2;
        float suma2= numerador2 * denominador1;
        resultadonumerador = suma1 + suma2;
        resultadodenominador= denominador1 * denominador2;
        Console.WriteLine("El Resultado de la suma es = " + resultadonumerador + "/" +  resultadodenominador);
    }
}

else if(operador=="-"){
    if(denominador1==denominador2){
        resultadonumerador=numerador1-numerador2;
        Console.WriteLine("El Resultado de la resta es = " + resultadonumerador + "/" + denominador1);
    }
    else{
        float resta1= numerador1 * denominador2;
        float resta2= numerador2 * denominador1;
        resultadonumerador = resta1 - resta2;
        resultadodenominador= denominador1 * denominador2;
        Console.WriteLine("El Resultado de la resta es = " + resultadonumerador + "/" +  resultadodenominador);
    }
}

else if(operador=="*"){
resultadonumerador= numerador1 * numerador2;
resultadodenominador= denominador1 * denominador2;
Console.WriteLine("El Resultado de la multiplicación es = " + resultadonumerador + "/" + resultadodenominador);
}

else if(operador=="/"){
resultadonumerador = numerador1 * denominador2;
resultadodenominador = numerador2 * denominador1;
Console.WriteLine("El Resultado de la division es = " + resultadonumerador + "/" + resultadodenominador);
}

else{
    Console.WriteLine("Operacion Invalida. Error de operador");
}
// PUNTO 2
Console.WriteLine("Ingrese el numero para determinar si es especial");
float num = float.Parse(Console.ReadLine());
bool condicion1=false;
bool condicion2=false;
if(num%5==0) condicion1=true;

if(num%2!=0 && num%3!=0) condicion2=true;

if (condicion1==true && condicion2==true)
Console.WriteLine("El Numero Es ESPECIAL");

else
Console.WriteLine("Numero Comun");

//PUNTO 3
Console.WriteLine("Ingrese la edad");
int edad= int.Parse(Console.ReadLine());
float semanas= 52.143f;
int contador= edad/4;
float semanasaprox = edad* semanas + contador;
float diasaprox= edad * (semanas*7);

Console.WriteLine("El total de semanas es de = " + semanasaprox + " y los días es de = " + diasaprox);
//PUNTO 4
string user="admin";
string pass="123";
int intentos=3;
Console.WriteLine("Bienvenido, inicie seccion");
 while(intentos>0){
    Console.WriteLine("Ingrese el usuario");
    string useringresado=Console.ReadLine();
    Console.WriteLine("Ingrese la constraseña");
    string passingresado=Console.ReadLine();
    if(useringresado==user && passingresado==pass){
        Console.WriteLine("Acceso concedido");
        break;
    }
    else{
    intentos--;
    if(intentos >0){
        Console.WriteLine("Usuario o contraseña incorrecto");
    }
    else{
        Console.WriteLine("Acceso denegado");
    }
    }
    
 } 
 Console.WriteLine("Fin Programa");
