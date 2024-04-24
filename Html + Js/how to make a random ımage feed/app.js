
/*querySelector() yöntemi, belgede belirtilen bir CSS seçiciyle eşleşen ilk öğeyi döndürür. 
Not: querySelector() yöntemi yalnızca belirtilen seçicilerle eşleşen ilk öğeyi döndürür.*/
const container = document.querySelector('.container')
const unsplashURL = 'https://source.unsplash.com/random/'
const rows = 9

for (let i = 0; i < rows * 3; i++) {
	/*createElement methodunda oluşturacağımız html etiketinin adını girmemiz yeterli olmaktadır.
	 Daha sonra içerisine bir veri girmek ister isek innerHTML ile içerisini doldurabilmekteyiz.*/
	const img = document.createElement('img')
	img.src = `${unsplashURL}${getRandomSize()}`

	//Var olan bir belgeye yeni öğeler eklemek veya sayfadaki bir öğeyi taşımak için kullanılır AppendChild .
	container.appendChild(img)
}

function getRandomNumber() {
	return Math.floor(Math.random() * 10) + 300
}

// console.log(getRandomNumber())

function getRandomSize() {
	return `${getRandomNumber()}x${getRandomNumber()}`
}

// console.log(getRandomSize())