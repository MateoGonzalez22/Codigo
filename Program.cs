

//string[] tiposDeEnemigos = {"ladron", "mago", "bruja", "monstruo", "perro", "gato"};



string[] tiposDeEnemigos = {"ladron", "mago", "bruja", "monstruo", "perro", "gato"};

List<string> DevolverArrayDeEnemigosListados(string[] tiposDeEnemigos){

    List<string> todosLosEnemigosEnumerados = new List<string>();
    int x = 1;

    for(int i = 0; i<50;)
    {
        foreach (string tipo in tiposDeEnemigos)
        {

            if(todosLosEnemigosEnumerados.Count < 50){
                todosLosEnemigosEnumerados.Add(tipo + x);
                i+=1;
            }
        }
        x+=1;
    }
    

    return todosLosEnemigosEnumerados;
}


// TESTEAR LA PARTE DE ENUMERAR ENEMIGOS EN 50 CASILLEROS

/*foreach (string enemigo in DevolverArrayDeEnemigosListados(tiposDeEnemigos))
{
    Console.WriteLine(enemigo);    
} */





List<List<string>> DevolverEnemigosOrdenadosPorListas(List<string> todosLosEnemigosEnumerados){

    List<List<string>> todosLosEnemigosOrdenados = new List<List<string>>();
    

    foreach (string tipo in tiposDeEnemigos)
    {
        
        
        List<string> listaDeEnemigos = new List<string>();

        foreach (string enemigo in todosLosEnemigosEnumerados)

        {
            
            if(enemigo.IndexOf(tipo) == 0){

                listaDeEnemigos.Add(enemigo);

            }
        }
        
        todosLosEnemigosOrdenados.Add(listaDeEnemigos);
        
    }
    
    return todosLosEnemigosOrdenados;
}



// TESTEAR TODO EL PROGRAMA

int i=1;

foreach(List<string> lista in DevolverEnemigosOrdenadosPorListas(DevolverArrayDeEnemigosListados(tiposDeEnemigos))){

    Console.WriteLine("\nLista " + i + "\n");

    foreach (string enemigo in lista)
    {
        Console.WriteLine(enemigo);
    }

    i+=1;

}



