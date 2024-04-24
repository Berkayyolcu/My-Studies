
/*Document.getElementById metodu, id özelliği belirtilen 
elementin referansının alınmasını sağlar.Aynı id kimliğine sahip başka 
bir element olması durumunda sadece ilk elementi verir.*/
const jokeEl = document.getElementById('joke')
const jokeBtn = document.getElementById('jokeBtn')


/*JavaScript addEventListener yöntemi, bir kullanıcı
 bir düğmeyi tıkladığında olduğu gibi, belirli bir olay 
 gerçekleştiğinde çağrılacak işlevleri ayarlamanıza olanak tanır. 
 Olaylar, kullanıcı veya tarayıcı bir sayfayı manipüle ettiğinde 
 gerçekleşen eylemlerdir.*/
 jokeBtn.addEventListener('click', generateJoke)


 generateJoke()

 // async
 async function generateJoke() {

 	const config = {
 		headers: {
 			Accept: 'application/json',
 		},
 		
 	}

 	const res = await fetch('https://icanhazdadjoke.com', config)

 	const data = await res.json()

 	jokeEl.innerHTML = data.joke
 }

// then
// function generateJoke() {
//   const config = {
//     headers: {
//       Accept: 'application/json',
//     },
//   }

//   fetch('https://icanhazdadjoke.com', config)
//     .then((res) => res.json())
//     .then((data) => {
//       jokeEl.innerHTML = data.joke
//     })
// }