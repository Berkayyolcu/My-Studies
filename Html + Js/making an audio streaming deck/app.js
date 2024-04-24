
/*JavaScript diziler birden fazla değeri bir değişkende depolamak için kullanılır.*/
/*Çoğu programlama dilinde bir dizinin tuttuğu bütün öğeler aynı veri türündendir
ve dizi ardışık bellek adresleriyle gösterilen konumlarda saklanır.*/
const sounds = ['applause', 'boo', 'gasp', 'tada', 'victory', 'wrong']

sounds.forEach((sound) => {
  //createElement : HTML nesnesi oluşturmak için kullanılır. 
  const btn = document.createElement('button')

  /*classList bir elementin sitil sınıflarını tutan bir nesnedir 
  ve bu nesnenin add metodu ile elemente yeni sınıflar eklenebilir.*/
  btn.classList.add('btn')

  btn.innerText = sound

/*addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında olduğu gibi,
belirli bir olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır.*/
btn.addEventListener('click', () => {
  stopSongs()

  document.getElementById(sound).play()
})

/*appencild : Var olan bir belgeye yeni öğeler eklemek veya sayfadaki bir 
 öğeyi taşımak için kullanın AppendChild . Bir öğe zaten üst öğeye eklenmişse,
 bir öğeyi başka bir öğeye eklemek, bu öğeyi önceki üst öğesinden 
 otomatik olarak kaldırır.*/
 document.getElementById('buttons').appendChild(btn)
})

function stopSongs() {
  sounds.forEach((sound) => {
    /*getElementById metodu, id özelliği belirtilen
     elementin referansının alınmasını sağlar. Aynı id 
     kimliğine sahip başka bir element olması durumunda 
     sadece ilk elementi verir.*/
     const song = document.getElementById(sound)

     song.pause()
   })
}