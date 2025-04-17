const URL = 'http://localhost:5237/api/interesses';

async function chamarApi(){
    const resp = await fetch(URL);
    console.log(resp);
    if (resp.status ===200){
        const obj = await resp.json();
        console.log(obj); 
       }
}
chamarApi();