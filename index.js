const { app, BrowserWindow, ipcMain } = require('electron')

const mysql = require('mysql2/promise');

async function connect() {
  connection = await mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'controlerevendedora'
  });

  return connection;
}

async function createWindow() {
  const win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      nodeIntegration: true
    }

  })

  win.maximize()
  win.loadURL('http://localhost:3000')
}

ipcMain.handle('mysql-execute', async (event, arg) => {
  let connection = await connect()
  var [rows, fields] = await connection.execute(arg[0], arg[1])

  return rows
})

ipcMain.handle('mysql-reader', async (event, arg) => {
  let connection = await connect()
  var [rows, fields] = await connection.execute(arg[0], arg[1])
  console.log(rows)
  connection.close()
  return rows
})


app.whenReady().then(createWindow)

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

app.on('activate', () => {
  if (BrowserWindow.getAllWindows().length === 0) {
    createWindow()
  }
})