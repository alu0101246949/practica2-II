# Informe de Práctica: Interfaces Inteligentes
### Estudiante: Laura Ramallo Pérez
### Asignatura: Interfaces Inteligentes

## Objetivo de la Práctica
El objetivo principal de esta práctica es profundizar en el conocimiento de Unity y en la programación de scripts para crear interacciones y manipulaciones de objetos dentro de una escena.

## Desarrollo de la Práctica

### Ejercicio 1: Manipulación de Array con Valores Aleatorios
Desarrollé un script en C# asociado a un cubo en Unity. Este script inicializa un array con valores aleatorios entre 0 y 25. A cada frame, una posición aleatoria del array es modificada y aquellos valores mayores a 15 son mostrados en la consola de Unity. Adicionalmente, parametricé el rango de valores aleatorios para facilitar modificaciones desde el inspector de Unity.

### Ejercicio 2: Creación de una Escena con Diferentes Objetos y Materiales
Construí una escena básica compuesta por un plano, un cubo, una esfera y un cilindro. Asigné a cada objeto un color diferente creando y utilizando materiales, los cuales fueron almacenados en una carpeta denominada “Materials” dentro de los Assets de Unity. Además, a través de un script, cada objeto muestra su nombre en la consola al inicio de la escena.

### Ejercicio 3: Trabajo con Vectores en Unity
Elaboré un script asociado a la esfera, donde definí dos vectores `Vector3` públicos. Realicé operaciones con estos vectores para mostrar en la consola y en el inspector su magnitud, el ángulo entre ellos, la distancia que los separa y un mensaje indicando cuál está a una altura mayor.

### Ejercicio 4: Mostrar la Posición de la Esfera
Mediante un script, logré mostrar la posición del objeto esfera en la consola, utilizando tanto la propiedad `transform.position` como la función `GetComponent<Transform>()`.

### Ejercicio 5: Cálculo de Distancias entre Objetos
Implementé un script que calcula y muestra en la consola la distancia entre la esfera y los otros dos objetos (cubo y cilindro).

### Ejercicio 6: Alineación de Objetos en un Eje Específico
Desarrollé un script que alinea automáticamente el cilindro y el cubo con la esfera, situándolos a 5 unidades a la derecha e izquierda respectivamente en el eje X.

### Ejercicio 7: Cambio de Color mediante Input del Usuario
Implementé la lógica para cambiar el color del cilindro y del cubo al presionar las teclas "A" y la flecha arriba respectivamente, utilizando la clase `Input` de Unity.

### Ejercicio 8: Manipulación de Grupos de Objetos y Distancias
Agregué 5 esferas a la escena, agrupándolas mediante etiquetas. Creé un vector con las distancias de un grupo de esferas respecto al cubo y, mediante un script, aumenté la altura de la esfera más cercana al cubo y cambié el color de la más lejana al pulsar la tecla espacio.

## Conclusión
Esta práctica ha sido esencial para familiarizarme más con el entorno de Unity y la lógica de programación en C# para desarrollar interacciones en escenas 3D. A través de los diferentes ejercicios, pude explorar y aprender acerca de la manipulación de objetos, vectores, materiales, y la captura de inputs del usuario en Unity.

---

Laura Ramallo Pérez
