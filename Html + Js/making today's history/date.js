


        var dt = new Date();    // DATE() ile yeni bir tarih nesnesi oluşturuldu.
        var date = dt.toLocaleDateString();
        // document.getElementById('dt_date').innerHTML = gun + "/" + ay+"/"+yil;
        document.getElementById('dt_date').innerHTML = date;

       //bu sekilde olusturulur
       //var bugun = new Date(); 
       //var tarih = bugun.getFullYear()+'-'+(bugun.getMonth()+1)+'-'+bugun.getDate();