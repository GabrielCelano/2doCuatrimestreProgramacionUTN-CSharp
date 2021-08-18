/*
insert into Provedores (Localidad)--Ingresar valores a las tablas
values ('Temperley')

insert into Productos values(4, 'Agua', 10.2, 'Grande')--puedo ingresar los valores sin los campos, si agrego en el orden que 

update Provedores set Domicilio = 'Anchoris 3070'--Modifico todos los valores de la tabla
where numero = 100--de esta forma filtro donde modificar

delete Provedores --borra el contenido de la tabla

delete Envios
where Numero = 101 and cantidad > 100 --filtramos que borrar

drop Provedores --borra la tabla entera

select numero, nombre, domicilio, localidad from Provedores---Trae las columnas que quiera de una tabla 

select * from Provedores
select * from Envios
select * from Productos

where numero >= 100 --where(donde) numero sea mayor o igual a 100
and localidad = 'avellaneda'--se puede seguir filtrando con un and
order by nombre asc --ordena de la forma que quiera asc/desc

select Nombre, Domicilio, Localidad
from Provedores
where nombre like 'G_%' --(like significa parecido, '_' que en esa posicion exista cualquier caracter, y '%' exista o no en esa y las demas posiciones cualquier caracter)
order by 2 --Ordenar por columna

select * --Une dos tablas filtradas
from Envios v
inner join Productos p --Interseccion
on v.pNumero = p.pNumero--On es como se van a relacionar las tablas
where p.pNombre = 'Cigarrillos'

select * --Une dos tablas filtradas
from Envios v right join Productos p --Muestra lo que se repite que cumplen la condicion y las que no la cumplen las marca con null(right o left)
on v.pNumero = p.pNumero
and p.pNombre = 'Gaseosa'

select max/min(p.Numero), p.Nombre --Condicion
from provedores p
inner join envios e
on p.Numero = e.Numero
group by p.Nombre --Agrupa todos en un campo
having count(p.Numero) > 100 
*/

select * from provedores
select * from productos
select * from envios

-- 1.Obtener los detalles completos de todos los productos, ordenados alfabéticamente.
select * 
from productos
order by pNombre asc

--2.Obtener los detalles completos de todos los proveedores de ‘Quilmes’.
select * 
from provedores 
where localidad = 'Quilmes'

--3.Obtener todos los envíos en los cuales la cantidad este entre 200 y 300 inclusive.
select * 
from envios
where cantidad > 200 and cantidad <= 300

--4. Obtener la cantidad total de todos los productos enviados.
select sum(e.Cantidad) 
from envios e

--5. Mostrar los primeros 3 números de productos que se han enviado.
select e.Numero
from Envios e

--6. Mostrar los nombres de proveedores y los nombres de los productos enviados.
select p.Nombre
from Provedores p
select pNombre
from Productos

--7. Indicar el monto (cantidad * precio) de todos los envíos.
select * from productos
select * from envios
select e.Cantidad * p.Precio
from envios e
inner join productos p
on p.pNumero = e.pNumero

--8. Obtener la cantidad total del producto 1 enviado por el proveedor 102.
select * from provedores
select * from envios
select e.Cantidad
from envios e
where e.Numero = 102 and e.pNumero = 1

--9. Obtener todos los números de los productos suministrados por algún proveedor de ‘Avellaneda’.
select e.pNumero
from Envios e
inner join Provedores p
on e.Numero = p.Numero
where p.Localidad =  'Avellaneda'

--10.Obtener los domicilios y localidades de los proveedores cuyos nombres contengan laletra ‘I’.
select p.Nombre, p.Domicilio, p.Localidad
from Provedores p
where p.Nombre like '%i%'

--11.Agregar el producto numero 4, llamado ‘Chocolate’, de tamaño chico y con un precio de 25,35.
insert into Productos values(4, 'Chocolate', 25.35, 'Chico')
select * from Productos

--12.Insertar un nuevo proveedor (únicamente con los campos obligatorios).
insert into Provedores values(103, 'Celano', 'Anchoris 3070', 'Temperley')
select * from Provedores

--13.Insertar un nuevo proveedor (107), donde el nombre y la localidad son ‘Rosales’ y ‘LaPlata’.
insert into Provedores values(107, 'Rosales', ' ', 'LaPlata')
select * from Provedores 

--14.Cambiar los precios de los productos de tamaño ‘grande’ a 97,50.
select * from Productos
update Productos 
set Precio = 97.50
where Tamaño = 'Grande'

--15.Cambiar el tamaño de ‘Chico’ a ‘Mediano’ de todos los productos cuyas cantidades sean mayores a 300 inclusive.
select * from Envios
select * from Productos
update Productos 
set Tamaño = 'Mediano'
from Productos p 
inner join Envios e 
on p.Tamaño = 'Chico' and e.Cantidad >= 300 and e.pNumero = p.pNumero

--16.Eliminar el producto número 1.
select * from Envios
select * from Productos
delete Envios
where pNumero = 1
delete Productos
where pNumero = 1

--17.Eliminar a todos los proveedores que no han enviado productos.
select * from Envios
select * from Provedores
delete Provedores
from envios e
where Numero != e.Numero