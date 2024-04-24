/* Document.getElementById metodu, id özelliği belirtilen elementin referansının alınmasını sağlar. 
Aynı id kimliğine sahip başka bir element olması durumunda sadece ilk elementi verir.*/
const tagsEl = document.getElementById('tags')
const textarea = document.getElementById('textarea')

textarea.focus()

/*addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında olduğu gibi, 
belirli bir olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır.
Olaylar, kullanıcı veya tarayıcı bir sayfayı manipüle ettiğinde gerçekleşen eylemlerdir.*/
textarea.addEventListener('keyup', (e) => {
  createTags(e.target.value)

  if (e.key === 'Enter') {
    setTimeout(() => {
      e.target.value = ''
    }, 10)

    randomSelect()
  }
})

function createTags(input) {
  //console.log(input)
  const tags = input
  .split(',')
  .filter((tag) => tag.trim() !== '')
  .map((tag) => tag.trim())
  //console.log(tags)


/*Html DOM üzerindeki bir öğenin içeriğini Html kodları ile birlikte alabilir 
veya seçtiğimiz Html öğesinin içerisine Html kodları ekleyebiliriz*/
tagsEl.innerHTML = ''

tags.forEach((tag) => {
  const tagEl = document.createElement('span')
  tagEl.classList.add('tag')
  tagEl.innerHTML = tag
  tagsEl.appendChild(tagEl)
})
}

function randomSelect() {
  //console.log(123)

  const times = 30

/*Bir işlemi belirli zaman aralıklarında tekrarlayan iki parametre alan bir JavaScript fonksiyonudur.
 Kullanımı setTimeout gibidir ve iki adet parametre alır. Birinci parametre çalıştırılacak fonksiyonu,
 ikinci parametre de bu işlemin kaç mili saniye de tekrar edileceğini temsil eder.28*/
 const interval = setInterval(() => {
  const randomTag = pickRandomTag()

  highlightTag(randomTag)

  setTimeout(() => {
    unHighLight(randomTag)
  }, 100)
}, 100)

 setTimeout(() => {
  clearInterval(interval)

  setTimeout(() => {
    const randomTag = pickRandomTag()

    highlightTag(randomTag)
  }, 100)
}, times * 100)
}

function pickRandomTag() {

  /*querySelectorAll() yöntemi, belgede belirtilen bir CSS seçiciyle eşleşen tüm öğeleri 
  statik bir NodeList nesnesi olarak döndürür. NodeList nesnesi 
  düğümlerin bir koleksiyonunu temsil eder. Düğümlere dizin numaraları erişilebilir.*/
  const tags = document.querySelectorAll('.tag')

  return tags[Math.floor(Math.random() * tags.length)]
}

function highlightTag(tag) {
  tag.classList.add('highlight')
}

function unHighLight(tag) {
  tag.classList.remove('highlight')
}