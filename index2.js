//Callback:
console.log('before')
 getUser(1,(user)=>{
    console.log('User',user);
})

console.log('after')

getUser(2,(user)=>{
    console.log('User',user);
})

function getUser(id,callback)
{
    setTimeout(()=>{
    console.log('reading the user details from database');
    callback( {id:id,gitHubUserName :'kfayazuddin'});
    callback( {id:id,gitHubUserName :'samp16'})
},2000);
}