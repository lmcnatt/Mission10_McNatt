import logo from './McNastyBowlingLeague.png';

function Header(props: any) {
  return (
    <header className="row navbar">
      <div className="col-4">
        <img src={logo} alt="logo" className="img-thumbnail" />
      </div>
      <div className="col subtitle">
        <h1 className="display-3 text-white">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
