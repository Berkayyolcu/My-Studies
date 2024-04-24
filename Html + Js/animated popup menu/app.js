
/*Document.getElementById metodu, id özelliği belirtilen elementin referansının alınmasını sağlar. 
Aynı id kimliğine sahip başka bir element olması durumunda sadece ilk elementi verir.*/
const nav = document.getElementById('nav')
const toggle = document.getElementById('toggle')

/*addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında olduğu gibi,
belirli bir olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır*/

/*classList bir elementin sitil sınıflarını tutan bir nesnedir ve bu nesnenin add
 metodu ile elemente yeni sınıflar eklenebilir. add metodu parametre olarak 
 eklenecek sitil sınıfının adını alır.*/
 toggle.addEventListener('click', () => nav.classList.toggle('active'))