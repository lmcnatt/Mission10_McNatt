import logo from './McNastyBowlingLeague.png';

function Header(props: any) {
  return (
    <header className="row navbar bg-dark">
      <div className="col-4">
        <img src={logo} alt="logo" className="img-thumbnail" />
      </div>
      <div className="col subtitle">
        <h1 className="display-2 text-white">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
