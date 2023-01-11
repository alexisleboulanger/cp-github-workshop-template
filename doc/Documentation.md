# Documentation

## Change log

### auto-changelog

#### Install npm using nvm (node version manager)

[Npm via node version manager](https://docs.npmjs.com/downloading-and-installing-node-js-and-npm#using-a-node-version-manager-to-install-nodejs-and-npm)  
[Nvm for lINUX](https://github.com/nvm-sh/nvm)  
[Nvm for windows](https://github.com/coreybutler/nvm-windows)

```sh
nvm install 14.0.0
nvm use 14.0.0
nvm list
npm config get prefix -g
# if not %APPDATA%\npm
npm config set prefix %APPDATA%\npm -g
npm config get prefix -g
```

#### Use auto-changelog

```sh
npm install auto-changelog -g 
auto-changelog
```

### git changelog

```sh
git log --pretty="- %s" > CHANGELOG.md
```

## Docx Generation from .md

Markdown to Docx convert :

[Pandoc](https://pandoc.org/)  

```powershell
choco install pandoc

pandoc -s .\Architecture.md -f markdown -t docx -o Architecture.docx
```

## Dependencies Graph

### Instal dependensee

```sh
cd apps

dotnet tool update -g dependensee
```

