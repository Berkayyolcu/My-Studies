
/*Document.getElementById metodu, id özelliği belirtilen elementin referansının alınmasını sağlar.
Aynı id kimliğine sahip başka bir element olması durumunda sadece ilk elementi verir.*/
const content = document.getElementById('content')
const speedEl = document.getElementById('speed')
const text = 'I am a computer program student and front-end developer'
let idx = 1
let speed = 300 / speedEl.value

writeText()

function writeText() {
	content.innerText = text.slice(0, idx)
	idx++

	if (idx > text.length) {
		idx = 1
	}

/*setTimeout fonksiyonu milisaniye cinsinden hesaplama yapar ve belirlenen süre sonunda fonksiyonu çalıştırır.
yani bir fonksiyonu belirli bir süre sonra çalıştırmak istiyorsanız setTimeout kullanabilirsiniz.*/
setTimeout(writeText, speed)
}

/*JavaScript addEventListener yöntemi, bir kullanıcı bir düğmeyi tıkladığında
 olduğu gibi, belirli bir olay gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır. 
 Olaylar, kullanıcı veya tarayıcı bir sayfayı manipüle ettiğinde gerçekleşen eylemlerdir.*/
 speedEl.addEventListener('input', (e) => (speed = 300 / e.target.value))